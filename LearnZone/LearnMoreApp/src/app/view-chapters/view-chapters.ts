import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Lzservice } from '../services/lzservice';

@Component({
  selector: 'app-view-chapters',
  standalone: false,
  templateUrl: './view-chapters.html',
  styleUrl: './view-chapters.css'
})
export class ViewChapters implements OnInit {

  chapterId!: number;
  courseId!: number;

  chapter: any;
  chapters: any[] = [];

  isLoading = false;
  errorMessage: string | null = null;

  constructor(
    private route: ActivatedRoute,
    private lzservice: Lzservice
  ) {}

  ngOnInit(): void {

    // IMPORTANT: subscribe so sidebar works when clicking chapters
    this.route.paramMap.subscribe(params => {
      this.chapterId = +params.get('chapterId')!;
      this.courseId = +params.get('courseId')!;

      this.loadChapter();
      this.loadChapters();
    });

  }

  loadChapter() {
    this.isLoading = true;

    this.lzservice.getChapter(this.chapterId).subscribe({
      next: (data) => {
        this.chapter = data;
        this.isLoading = false;
        console.log('Current chapter:', this.chapter);
      },
      error: (err) => {
        console.error('Error loading chapter', err);
        this.isLoading = false;
      }
    });
  }

  loadChapters() {
    this.lzservice.getChapteronCourseId(this.courseId).subscribe({
      next: (data) => {
        this.chapters = data;
      },
      error: (err) => {
        console.error('Error loading chapters list', err);
      }
    });
  }
}
